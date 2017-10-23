﻿using SS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpreadsheetGUI
{
    /// <summary>
    /// Controllable interface for the Spreadsheet GUI
    /// </summary>
    public interface ISpreadsheetWindow
    {
        event Action NewSheetAction;

        SpreadsheetPanel GetSpreadsheetPanel();

        string CurrentCellText { set; }

        void CreateNew();

    }
}
