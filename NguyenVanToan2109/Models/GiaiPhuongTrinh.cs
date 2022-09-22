using Microsoft.AspNetCore.Mvc;

namespace NguyenVanToan2109.Models
{
    public class GiaiPhuongTrinh
    {
        public string GiaiPhuongTrinhBacNhat(double hesoA, double hesoB)
        {
            double x;
            string message = "";
            if (hesoA == 0)
            {
                if (hesoB == 0)
                {
                    message = "Phuong trinh co vo so nghiem";
                }
                else
                {
                    message = "Phuong trinh vo nghiem";
                }
            }

            else
            {
                x = -hesoB / hesoA;
                message = "Phuong trinh co nhiem x =" + x;
            }
            return message;

        }
        public string GiaiPhuongTrinhBac2(double hesoA, double hesoB, double hesoC)
        {
            string message2 = "";
            double delta, x1, x2, x3;

            if (hesoA == 0)
            {
                message2 = GiaiPhuongTrinhBacNhat(hesoB, hesoC);
                if (hesoB == 0)
                {
                    if (hesoC == 0)
                    {
                        message2 = "phuong trinh vo so nghiem";

                    }
                    else
                    {
                        message2 = "phuong trinh vo nghiem";
                    }
                }
                else
                {
                    x1 = -hesoC / hesoB;
                    message2 = " phuong trinh có nghiem duy nhat:" + x1;
                }
            }

            else
            {

                delta = Math.Pow(hesoB, 2) - 4 * hesoA * hesoC;
                if (delta < 0)
                {
                    message2 = "phuong trinh vo nghiem";
                }
                else if (delta == 0)
                {
                    x2 = x3 = -hesoB / (2 * hesoA);
                    message2 = "phuong trinh co nghiem kep x2, x3:" + x2;
                }
                else
                {
                    x2 = (-hesoB + Math.Sqrt(delta)) / (2 * hesoA);
                    x3 = (-hesoB - Math.Sqrt(delta)) / (2 * hesoA);
                    message2 = "phuong trinh co 2 nghiem phan biet:" + x2 + " va " + x3;
                }

            }
            return message2;
        }


    }
}
