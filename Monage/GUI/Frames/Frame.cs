using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monage.GUI.Frames {
    public interface Frame {
        void Set(MainFrame p, Panel c);
        void Adjust();
    }
}
