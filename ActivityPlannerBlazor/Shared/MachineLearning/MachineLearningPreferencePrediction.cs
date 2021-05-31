using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.ML.Trainers;
namespace ActivityPlannerBlazor.Shared.MachineLearning
{
    public class MachineLearningPreferencePrediction
    {
        public static ITransformer RetrainModel(MLContext mlContext, IDataView trainingDataView)
        {
            DataViewSchema dataPrepPipelineSchema, modelSchema;
            var trainedModel = mlContext.Model.Load("./diehard-model.zip", out modelSchema);
            var dataPrePipeline = mlContext.Model.Load("./diehard-pipeline.zip", out dataPrepPipelineSchema);

            IDataView transformedData = dataPrePipeline.Transform(trainingDataView);
            IEnumerable<ITransformer> chain = trainedModel as IEnumerable<ITransformer>;
            ISingleFeaturePredictionTransformer<object> predictionTransformer = chain.Last() as ISingleFeaturePredictionTransformer<object>;
            var originalModelParameters = predictionTransformer.Model as LinearBinaryModelParameters;

            var model = dataPrePipeline
                .Append(mlContext
                    .BinaryClassification
                    .Trainers
                    .AveragedPerceptron(labelColumnName: "ILikeDieHard", numberOfIterations: 10, featureColumnName: "Features")
                    .Fit(transformedData, originalModelParameters));

            mlContext.Model.Save(model, trainingDataView.Schema, "./diehard-model.zip");

            return model;
        }

        public static ITransformer TrainNewModel(MLContext mlContext, IDataView trainingDataView)
        {
            var dataPrepPipeline = mlContext
                .Transforms
                .Concatenate(
                    outputColumnName: "Features",
                    "StarWarsScore",
                    "ArmageddonScore",
                    "SleeplessInSeattleScore")
                .AppendCacheCheckpoint(mlContext);

            var prepPipeline = dataPrepPipeline.Fit(trainingDataView);

            mlContext.Model.Save(prepPipeline, trainingDataView.Schema, "./diehard-pipeline.zip");

            var trainer = dataPrepPipeline.Append(mlContext
                .BinaryClassification
                .Trainers
                .AveragedPerceptron(labelColumnName: "ILikeDieHard", numberOfIterations: 10, featureColumnName: "Features"));

            var preprocessedData = prepPipeline.Transform(trainingDataView);
            var model = trainer.Fit(preprocessedData);
            mlContext.Model.Save(model, trainingDataView.Schema, "./diehard-model.zip");
            return model;
        }

    }
}
