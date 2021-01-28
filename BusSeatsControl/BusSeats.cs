using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusSeatsControl
{
    public partial class BusSeats : UserControl
    {
        public BusSeats()
        {
            InitializeComponent();
            _freeSeats = _capacity;
        }

        private int _capacity = 11;
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        private int _freeSeats;
        public int FreeSeats
        {
            get { return _freeSeats; }
            set { _freeSeats = value; }
        }

        public event EventHandler<EventArgs> SeatReservedEvent;

        private void seat_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Occu";
            ((Button)sender).BackColor = Color.Red;
            ((Button)sender).Enabled = false;
            _freeSeats--;
            SeatReservedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
