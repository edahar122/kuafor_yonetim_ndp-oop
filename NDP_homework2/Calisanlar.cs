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

namespace NDP_homework2 {

    public abstract class Person {
        public Guid CalisanID { get; private set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Phone { get; set; }

        public Person() {
            CalisanID = Guid.NewGuid();
        }
    }

    public class Müşteri : Person {
    }

    public class Calisan : Person {
    }
}