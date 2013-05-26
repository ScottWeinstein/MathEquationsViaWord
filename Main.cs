using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Office.Interop.Word;

namespace Eq2Png
{
    class App
    {
        public static void Main(string[] args)
        {
            var eq = string.Join(" ", args);

            Application _wordApp = new Application();

            string saveNameBase = System.IO.Path.Combine(System.IO.Path.GetTempPath(), Guid.NewGuid().ToString("N"));
            string _saveName = saveNameBase + ".html";
            string _extractPath = saveNameBase + @"_image001.png";

            _wordApp.Visible = false;
            Document _doc = _wordApp.Documents.Add();
            Range _range = _doc.Range();
            
            _range.Text = eq;
            _doc.OMaths.Add(_range);
            _doc.OMaths.BuildUp();
            _doc.SaveAs(_saveName, WdSaveFormat.wdFormatHTML, Type.Missing, Type.Missing, false, Type.Missing, null, false);
            Console.WriteLine("Equation {0} converted to {1}", eq, _extractPath);

            _wordApp.Documents.Close(WdSaveOptions.wdDoNotSaveChanges);
            ((_Application)_wordApp).Quit(false);
        }   
    }
}
