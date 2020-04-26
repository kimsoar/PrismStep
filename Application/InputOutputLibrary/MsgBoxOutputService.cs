using InterfacesLibrary;
using System.Windows.Forms;

namespace InputOutputLibrary
{
    public class MsgBoxOutputService : IOutputService
    {
        public void WriteMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
