﻿using SS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpreadsheetGUI
{
    /// <summary>
    /// Controllable interface for the Spreadsheet GUI
    /// </summary>
    public interface ISpreadsheetWindow
    {
        event Action NewSheetAction;

        event Action EnterContentsAction;

        event Action SaveFileAction;

        event Action OpenFileAction;

        event Action AboutText;

        event Action HowToUseText;

        /// <summary>
        /// Gets the spreadsheet panel component in this window
        /// </summary>
        SpreadsheetPanel GetSpreadsheetPanel();

        /// <summary>
        /// Sets the text field of the CurrentCell_Text component
        /// </summary>
        string CurrentCellText { set; }

        /// <summary>
        /// Sets the Value_Text.Text
        /// </summary>
        string ValueBoxText { set; }

        /// <summary>
        /// Sets the Contents_Text.Text
        /// </summary>
        string ContentsBoxText { get; set; }

        /// <summary>
        /// Sets the text of this window
        /// </summary>
        string WindowText { get; set; }

        /// <summary>
        /// Creates a new window containing an empty spreadsheet.
        /// </summary>
        void CreateNew();

        /// <summary>
        /// Shows an error message box with the coresponding message
        /// </summary>
        void ShowErrorMessageBox(string message);

        /// <summary>
        /// Shows a message box which can be canceled with a coresponding message and caption
        /// </summary>
        bool ShowOkayCancelMessageBox(string message, string caption);

        /// <summary>
        /// Sets the cell in the SpreadsheetPanel located at row, col to the string text
        /// </summary>
        void SetCellText(int row, int col, string v);

        /// <summary>
        /// Gets the currently selected cell location
        /// </summary>
        void GetCellSelection(out int row, out int col);

        /// <summary>
        /// Allows controller to close this window
        /// </summary>
        void CloseWindow();

        /// <summary>
        /// Sets the default accept button as contents_button
        /// </summary>
        void SetDefaultAcceptButton();

        /// <summary>
        /// Sets focus to the contents_text box
        /// </summary>
        void SetFocusToContentBox();

        /// <summary>
        /// Allows controller to add an action to the FormClosing event
        /// </summary>
        void AddFormClosingAction(Action FormClosingAction);

        /// <summary>
        /// sets the default cell as selected in the spreadsheet panel
        /// </summary>
        void SetCellSelectionToDefault();
    }
}
