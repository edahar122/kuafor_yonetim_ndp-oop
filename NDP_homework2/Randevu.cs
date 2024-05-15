/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:3 PROJE
**				ÖĞRENCİ ADI............:SERHAT HAR
**				ÖĞRENCİ NUMARASI.......:G231210040
**              DERSİN ALINDIĞI GRUP...:2A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_homework2 {//randevu duzenleme geldi silme gelecek
    public abstract class Work {
        
        public String tarih { get; set; }
        public int ucret { get; set; }
        public string hizmet { get; set; }
    }

    public class Randevu : Work {
        public Guid WorkID { get; private set; }
        public String müşteri { get; set; }
        public String müşteri_ulaşım { get; set; }
        public String calisan { get; set; }

        public Randevu() {
            WorkID = Guid.NewGuid();
        }
    }
}
