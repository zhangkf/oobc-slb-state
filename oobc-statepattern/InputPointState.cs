namespace oobc_statepattern
{
    public class InputPointState : InputState
    {
        public void Input(StateContext stateContext, string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                stateContext.SetState(new InputEndState());
            }
            else
            {
                stateContext.GetDrawer().AddPoint(inputString);
                stateContext.SetState(new InputPointState());

            }
        }

        protected bool Equals(InputPointState other)
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((InputPointState) obj);
        }

        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }

        public static bool operator ==(InputPointState left, InputPointState right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InputPointState left, InputPointState right)
        {
            return !Equals(left, right);
        }
    }
}
