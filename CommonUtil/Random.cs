using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtil {
    public static class Rand {
        private static Random rand = new Random();
        public static double NextDouble() {
            return rand.NextDouble();
        }
    }
}
