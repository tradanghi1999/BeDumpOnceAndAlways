using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaiLieuChuyenTin
{
    public class SourceCode
    {
        public List<int> GiaiBaiToan8QuanHau()
        {
            List<int> answer = new List<int>();
            KiemTraXemChuSoXuatHienNhieuLan(12345678);
            for (int i = 10000000; i < 100000000; i++)
            {
                if(!i.ToString().Contains("0")&&!i.ToString().Contains("9"))
                {
                    if(KiemTraXemChuSoXuatHienNhieuLan(12345678) == true)
                    {
                        if (TestNghiemBaiToan8QuanHau(i) == true)
                        {
                            answer.Add(i);
                        }
                    }
                }
            }    
            return answer;
        }
        private bool TestNghiemBaiToan8QuanHau(int a)
        {
            if(a >= 1000000000 || a <= 9999999)
                return false;
            int[] nghiemDeTest = new int[8];
            //
            int tam = a;
            for(int i  = 1; i <= 8; i++)
            {
                nghiemDeTest[8 - i] = tam % 10 - 1;
                tam = tam / 10; 
            }
            //
            for(int i = 0; i <= 7; i++)
            {
                for(int j= i + 1; j<=7; j++)
                {
                    if (nghiemDeTest[j] - nghiemDeTest[i] == j - i)
                        return false;
                }
            }
            return true;
        }
        private bool KiemTraXemChuSoXuatHienNhieuLan(int a)
        {
            for(int i = 0; i <= 9; i++)
            {
                int dem = 0;
                for(int j = a; j > 0; j= j / 10)
                {
                    if (j % 10 == i)
                        dem++;
                    if (dem >= 2)
                        return false;
                }
            }
            return true;
        }
    }
}
