using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Text;

/// include Charles Peltzold's namespace
using Petzold.ProgrammingWindowsWithCSharp;

namespace DigitalClock
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class DigitalDisplay : System.Windows.Forms.UserControl
	{
		private System.ComponentModel.IContainer components;

		private string strSeconds;
		private string strMinutes;
		private string strHours;

		private int nSeconds;
		private int nMinutes;
		private System.Windows.Forms.Timer displayTimer;
		private int nHours;


		private int nCountUpSeconds;
		private int nCountUpMinutes;
		private int nCountUpHours;

		/// <summary>
		/// if set to true the window will be drawn using the 
		/// system default background colour instaed of grey
		/// </summary>
		private bool bUseWindowColours = false;
		private bool bCountDown = true;
		private bool bFinished = false;

		/// <summary>
		/// Get and Set the value for the minutes
		/// </summary>
		public string Minutes
		{
			get
			{
				return strMinutes;
			}
			set
			{
				if( Int32.Parse( value ) > 0 )
					CalculateFromMinutes( Int32.Parse( value ) );
				strMinutes = value;
			}
		}

		/// <summary>
		/// Get and Set the value for the seconds
		/// </summary>
		public string Seconds
		{
			get
			{
				return strSeconds;
			}
			set
			{
				if( Int32.Parse( value ) > 0 )
					CalculateFromSeconds( Int32.Parse( value ) );
				strSeconds = value;
			}
		}

		/// <summary>
		/// Get and Set the value for the hours
		/// </summary>
		public string Hours
		{
			get
			{
				return strHours;
			}
			set
			{
				strHours = value;
				nHours = Int32.Parse( value );
			}
		}

		/// <summary>
		/// allow the default window colours to be used
		/// </summary>
		public bool UseWindowColours
		{
			get
			{
				return bUseWindowColours;
			}
			set
			{
				bUseWindowColours = value;
			}
		}


		/// <summary>
		/// set which way the count goes
		/// </summary>
		public bool CountDown
		{
			get
			{
				return bCountDown;
			}
			set
			{
				bCountDown = value;
			}
		}

		/// <summary>
		/// allow using software to check if finished
		/// </summary>
		public bool Finished
		{
			get
			{
				return bFinished;
			}
		}

        /// <summary>
        /// allow using software to check if running
        /// </summary>
        public bool Running
        {
            get
            {
                return displayTimer.Enabled;
            }
        }

		/// <summary>
		/// Start the display
		/// </summary>
		public void Start()
		{
			bFinished = false;

            if (displayTimer.Enabled)
            {
                // If we are already running, don't do anything
            }
            else
            {
                displayTimer.Interval = 1000;
                displayTimer.Enabled = true;
            }
		}

		/// <summary>
		/// Stop the display, and say we're finished
		/// </summary>
		public void Stop()
		{
			bFinished = true;
			displayTimer.Enabled = false;
		}

        /// <summary>
        /// pause display, but don't mark as finished
        /// </summary>
        public void Pause()
        {
            bFinished = false;
            displayTimer.Enabled = false;
        }

        public void Reset()
        {

            nSeconds = 0;
            nMinutes = 0;
            nHours = 0;
            strSeconds = "00";
            strMinutes = "00";
            strHours = "00";
        }
        


		public DigitalDisplay()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call
			strSeconds = "00";
			strMinutes = "00";
			strHours = "00";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.displayTimer = new System.Windows.Forms.Timer(this.components);
			// 
			// displayTimer
			// 
			this.displayTimer.Tick += new System.EventHandler(this.OnDisplayTimer);
			// 
			// DigitalDisplay
			// 
			this.Name = "DigitalDisplay";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.DigitalDisplay_Paint);

		}
		#endregion

		/// <summary>
		/// Paint the window
		/// Note the actual display painting is handled by Charles Petzold's
		/// SevenSegmentDisplay class.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DigitalDisplay_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			SevenSegmentDisplay ssd = new SevenSegmentDisplay( e.Graphics );

			if( UseWindowColours == true )
			{
				/// Doesn't get rid of the trailling resize though before it starts
				Graphics grfx = e.Graphics;
				/// use the window background colour so changed default colours should
				/// work
				grfx.Clear( SystemColors.Window );
			}

			/// set the time to that held by the internal values
			/// Use a stringbuilder to format the string correctly
			string strTime;
			StringBuilder strBuilder = new StringBuilder();
			if( nHours < 10 )
				strBuilder.Append( "0" );
			strBuilder.Append( nHours.ToString() + ":" );
			if( nMinutes < 10 )
				strBuilder.Append( "0" );
			strBuilder.Append( nMinutes.ToString() + ":" );
			if( nSeconds < 10 )
				strBuilder.Append( "0" );
			strBuilder.Append( nSeconds.ToString() );
			strTime = strBuilder.ToString();

			SizeF  sizef   = ssd.MeasureString(strTime, Font);
			float  fScale  = Math.Min(ClientSize.Width  / sizef.Width,
				ClientSize.Height / sizef.Height);
			Font   font    = new Font(Font.FontFamily, 
				fScale * Font.SizeInPoints);

			sizef = ssd.MeasureString(strTime, font);

			ssd.DrawString(strTime, font, Brushes.Green, 
				(ClientSize.Width  - sizef.Width) / 2, 
				(ClientSize.Height - sizef.Height) / 2);

		}

		/// <summary>
		/// calculate the number of seconds, minutes and hours from seconds passed
		/// </summary>
		/// <param name="seconds"></param>
		private void CalculateFromSeconds( int seconds )
		{
			if( seconds > 60 )
			{
				nMinutes = seconds/60;
				/// seconds = the remainder
				nSeconds = seconds - ( nMinutes * 60 );
				if( nMinutes > 60 )
				{
					nHours = nMinutes/60;
					/// minutes = remainder
					nMinutes = nMinutes - ( nHours * 60 );
				}
			}
			else
			{
				nSeconds = seconds;
			}

		}


		/// <summary>
		/// calculate the number of minutes and hours from the minutes passed
		/// </summary>
		/// <param name="minutes"></param>
		private void CalculateFromMinutes( int minutes )
		{
			if( minutes > 60 )
			{
				nHours = minutes/60;
				nMinutes = minutes - ( nHours * 60 );

				nMinutes--;
				nSeconds = 59;
			}
			else
			{
				nMinutes = minutes;
			}
		}

		/// <summary>
		/// Every second update the display string
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDisplayTimer(object sender, System.EventArgs e)
		{
			if( bCountDown == true )
			{
				if( nSeconds == 0 )
				{
					if( nMinutes == 0 )
					{
						if( nHours == 0 )
						{
							displayTimer.Enabled = false;
							bFinished = true;
						}
						else
						{
							nHours--;
							nMinutes = 59;
							nSeconds = 59;
							strHours.Replace( strHours, nHours.ToString() );
							strMinutes.Replace( strMinutes, nMinutes.ToString() );
							strSeconds.Replace( strSeconds, nSeconds.ToString() );
						}
					}
					else
					{
						nMinutes--;
						nSeconds = 59;
						strSeconds.Replace( strSeconds, nSeconds.ToString() );
						strMinutes.Replace( strMinutes, nMinutes.ToString() );
					}
				}
				else
				{
					nSeconds--;
					strSeconds.Replace( strSeconds, nSeconds.ToString() );
				}
			}
			else
			{
                /// For now I don't want an end point, just go until stopped
                // if we have reached our setpoint, disable timer, and trip finished flag.
                //if( nSeconds == nCountUpSeconds && nMinutes == nCountUpMinutes && nHours == nCountUpHours )
                //{
                //    displayTimer.Enabled = false;
                //    bFinished = true;
                //}
                //else
                //{					
					if( nSeconds == 59 )
					{
						nSeconds = 0;
						strSeconds.Replace( strSeconds, nSeconds.ToString() );
						nMinutes++;
						if( nMinutes == 59 )
						{
							nMinutes = 0;
							strMinutes.Replace( strMinutes, nMinutes.ToString() );

							/// don't stop the hours increasing beyond 24
							/// Even though the stop watch app wont allow this
							nHours++;
							strHours.Replace( strHours, nHours.ToString() );
						}
						else
						{
							strMinutes.Replace( strMinutes, nMinutes.ToString() );
						}
					}
					else
					{
						nSeconds++;
						strSeconds.Replace( strSeconds, nSeconds.ToString() );
					}
                //}
			}

			this.Invalidate();
		}

	}
}
