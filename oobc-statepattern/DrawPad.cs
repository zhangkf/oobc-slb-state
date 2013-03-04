namespace oobc_statepattern
{
    public class StateContext
    {
        private InputState _inputState;
        private LineDrawer _lineDrawer;

        public StateContext()
        {
            SetState(new InputShapeTypeState());
        }

        public void SetState(InputState inputState)
        {
            _inputState = inputState;
        }

        public void Input(string inputString)
        {
            _inputState.Input(this, inputString);
        }

        public void SetDrawer(LineDrawer lineDrawer)
        {
            _lineDrawer = lineDrawer;
        }

        public Line Draw()
        {
            return _lineDrawer.Draw();
        }

        public LineDrawer GetDrawer()
        {
            return _lineDrawer;
        }

        public InputState GetState()
        {
            return _inputState;
        }
    }
}