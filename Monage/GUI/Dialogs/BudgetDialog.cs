using Monage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI.Dialogs {
    public partial class BudgetDialog : Form {
        private BudgetDialog(string prompt, string caption, string name, string description, int id) {
            InitializeComponent();
            this.Text = caption;
            this.lblPrompt.Text = prompt;
            this.txtName.Text = name;
            this.txtDescription.Text = description;

            BindingList<KeyValuePair<int, string>>
                Buckets = new BindingList<KeyValuePair<int, string>>();

            Buckets.Add(new KeyValuePair<int, string>(0, "Select a Bucket"));
            foreach (Bucket bucket in Bucket.Enumerate()) {
                Buckets.Add(new KeyValuePair<int, string>(bucket.ID, bucket.Name));
            }

            cbxBuckets.DataSource = Buckets;
            cbxBuckets.ValueMember = "Key";
            cbxBuckets.DisplayMember = "Value";
            cbxBuckets.SelectedValue = id;

            txtName.Focus();
        }

        public static Trio ShowDialog(string prompt, string caption, string val = "", string description = "", int id = 0) {
            BudgetDialog i = new BudgetDialog(prompt, caption, val, description, id);
            return
                i.ShowDialog(Program.Window) == DialogResult.OK
                ? new Trio(
                    i.txtName.Text,
                    i.txtDescription.Text,
                    Session.db.Buckets
                        .FirstOrDefault(x => x.ID == (int)i.cbxBuckets.SelectedValue))
                : null;
        }
    }
}
