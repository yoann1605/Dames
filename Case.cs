using System;

namespace Dames {
    class Case {
        
        private int etat = 1;
        private int x;
        private int y;

        public Case (int xp, int yp){
            x = xp;
            y = yp;
        }

        public int Etat  {get { return etat; }}
        public int X { get { return x;}}
        public int Y { get { return y;}}
        public bool Occuper(int i, int j){
            if(this.etat == 1){
                 return true;
            }
            else {
                return false;
            }
        }
        

    }
}