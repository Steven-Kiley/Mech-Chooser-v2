using MChooser.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MChooser.Execution
{
    public class ExecutionController
    {
        SelectionForm SelectionForm;
        AddMechForm AddMechForm;

        public ExecutionController()
        {
            this.SelectionForm = new SelectionForm(SwitchToAddMechWindow);
            this.AddMechForm = new AddMechForm(SwitchToSelectionWindow);

            Application.Run(SelectionForm);
        }

        public void SwitchToAddMechWindow()
        {
            this.SelectionForm.Hide();
            this.AddMechForm.Show();
        }

        public void SwitchToSelectionWindow()
        {
            this.SelectionForm.Show();
            this.AddMechForm.Hide();
        }
    }
}
