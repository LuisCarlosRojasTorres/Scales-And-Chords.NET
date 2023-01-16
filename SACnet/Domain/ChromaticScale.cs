using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ChromaticScale
    {
        private List<string> chromaticBase = new List<string>{ "C", "C#", "D", "C#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        public ChromaticScale() {
        
        }    
        public List<string> getChromaticScaleShifted(string note)
        {
            int indexOfNote = chromaticBase.IndexOf(note);

            List<string> ans= new List<string>();
            for (int i = 0; i < chromaticBase.Count(); i++) 
            {
                ans.Add(chromaticBase[(i+indexOfNote)%chromaticBase.Count()]);
            }
            return ans;
        }
    }
}
