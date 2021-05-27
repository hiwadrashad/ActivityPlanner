using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Text;
using System.Threading;

namespace UnitTesting.BlackBox
{
    class GlobalizationTesting
    {
        [Test]
        public void Globalization()
        { 
            CultureInfo ci = CultureInfo.InstalledUICulture;
            Console.WriteLine("Default Language Info:" ) ;
            Console.WriteLine("* Name: {0}"                    , ci.Name ) ;
            Console.WriteLine("* Display Name: {0}"            , ci.DisplayName ) ;
            Console.WriteLine("* English Name: {0}"            , ci.EnglishName ) ;
            Console.WriteLine("* 2-letter ISO Name: {0}"       , ci.TwoLetterISOLanguageName ) ;
            Console.WriteLine("* 3-letter ISO Name: {0}"       , ci.ThreeLetterISOLanguageName ) ;
            Console.WriteLine("* 3-letter Win32 API Name: {0}" , ci.ThreeLetterWindowsLanguageName ) ;
        }
    }
}
