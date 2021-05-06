using ActivityPlannerBlazor.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityPlannerBlazor.Server.Repos
{
    public class InitialRepo
    {
        private List<InitialModel> _model { get; set; }

        private static InitialRepo _InitialRepo;

        private InitialRepo()
        { 
        
        }

        public static InitialRepo GetInitialRepo()
        {
            if (_InitialRepo == null)
            {
                _InitialRepo = new InitialRepo();
                _InitialRepo.InitData();
            }
            return _InitialRepo;
        }

        public void InitData()
        {
            _model = new List<InitialModel>()
            {
             new InitialModel
             {
               id = Guid.NewGuid().ToString(),
               Text = "InitialText"
             }
            };
        }

        public bool AddInitial(InitialModel model)
        {
            model.id = Guid.NewGuid().ToString();
            _model.Add(model);
            return true;
        }

        public InitialModel AddInitalAndReturnModel(InitialModel model)
        {

            model.id = Guid.NewGuid().ToString();
            _model.Add(model);
            return model;
        }

        public bool RemoveInitial(string id)
        {
            _model.Remove(_model.Where(a => a.id == id).FirstOrDefault());
            return true;
        }

        public List<InitialModel> ReturnAllInitialModels()
        {
            return _model;
        }

        public InitialModel ReturnInitialModel(string id)
        {
            return _model.Where(a => a.id == id).FirstOrDefault();
        }

        public bool UpdateInitialModel(InitialModel model)
        {
            var item = _model.Where(a => a.id == model.id).FirstOrDefault();
            item.id = model.id;
            item.Text = model.Text;
            return true;
        }
    }
}
