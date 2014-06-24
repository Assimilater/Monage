using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI.Frames.Controls {
    public partial class BudgetListPane : ListPane {
        public BudgetListPane() {
            InitializeComponent();
        }
        public override bool Ready(string con, string conf) { return true; }
    }
}
