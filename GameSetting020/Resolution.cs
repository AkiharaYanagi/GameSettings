using System;

namespace ScriptEditor
{
	enum RESOLUTION
	{
		R0_W = 1280,
		R0_H = 960,
		R1_W = 960,
		R1_H = 720,
		R2_W = 640,
		R2_H = 480,
	}

	//------------------------------------------
	//	ディスプレイ解像度を指定する
	//------------------------------------------
	public class Resolution
	{
		public int W { get; set; } = 0;
		public int H { get; set; } = 0;

		public Resolution ( int w, int h )
		{
			W = w; H = h;
		}

		public override string ToString ()
		{
			return W.ToString () + ", " + H.ToString ();
		}

		public override bool Equals ( object obj )
		{
			if ( obj is null || this.GetType () != obj.GetType () )
			{
				return false;
			}

			Resolution r = (Resolution)obj;
			return (W == r.W) && (H == r.H);
		}

		public override int GetHashCode ()
		{
			return base.GetHashCode ();
		}
	}

}
