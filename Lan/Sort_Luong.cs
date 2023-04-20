using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Lan
{
    class Sort_Luong: IComparer
    {
        public int Compare(object x, object y )
        {
            Nhanvien p1 = x as Nhanvien;
            Nhanvien p2 = y as Nhanvien;
            if(p1.Luong > p2.Luong){
                return 1;
            }
            else if (p1.Luong == p2.Luong){
                return 0;
            }
            else
                return -1;

        }
    }
}
