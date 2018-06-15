using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThietBi
    {
		private string maThietBi;
		private string tenThietBi;
		private string maNCC;
		private string dvt;
		private string donGia;


		public string MaThietBi
		{
			get
			{
				return maThietBi;
			}

			set
			{
				maThietBi = value;
			}
		}

		public string TenThietBi
        {
            get
            {
                return tenThietBi;
            }

            set
            {
                tenThietBi = value;
            }
        }

		public string MaNCC
		{
			get
			{
				return maNCC;
			}

			set
			{
				maNCC = value;
			}
		}

		public string DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
				donGia = value;
            }
        }



		public string DVT
		{
			get
			{
				return dvt;
			}

			set
			{
				dvt = value;
			}
		}
	}
}
