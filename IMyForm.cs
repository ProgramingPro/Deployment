using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMyForm
{
    bool CheckToExit { get; set; }
}

/*
 * FOLLOW THE PATTERN IN FORM1
 * Every form has to extend the IMyForm
 * Every button that goes to next form (and close current) should set the CheckToExit to value false
 * Form?_Load should set CheckToExit = true;
 * Every Form?_FormClosing should have the same logic as FORM1
 */
