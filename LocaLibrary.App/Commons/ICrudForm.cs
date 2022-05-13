using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace LocaLibrary.App.Commons
{
    internal interface ICrudForm
    {
        DataGridView GetGrid();

        string GetSelectedId();

        void EmptyForm();

        string ValidateForm();

        void LoadAll();

        void Create();

        void Update(string id);

        void Delete(string id);
    }
}
