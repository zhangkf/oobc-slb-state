using System;
using System.Collections.Generic;
using System.Text;

namespace oobc_statepattern
{
    public class InputShapeTypeState : InputState
    {
        public void Input(StateContext stateContext, string inputString)
        {
            if (inputString == "line")
            {
                stateContext.SetDrawer(new LineDrawer());
                stateContext.SetState(new InputPointState());
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        protected bool Equals(InputShapeTypeState other)
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((InputShapeTypeState) obj);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(InputShapeTypeState left, InputShapeTypeState right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InputShapeTypeState left, InputShapeTypeState right)
        {
            return !Equals(left, right);
        }
    }
}
