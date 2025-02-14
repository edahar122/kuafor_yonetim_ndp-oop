using System;

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
