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