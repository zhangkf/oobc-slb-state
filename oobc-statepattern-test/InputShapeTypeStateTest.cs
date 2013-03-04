using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oobc_statepattern;
using FluentAssertions;

namespace oobc_statepattern_test
{
    [TestClass]
    public class InputShapeTypeStateTest
    {
        [TestMethod]
        public void should_set_line_drawer_and_state_to_context()
        {
            var stateContext = new DrawPad();
            stateContext.GetState().Should().Be(new InputShapeTypeState());

            var inputShapeTypeState = new InputShapeTypeState();
            inputShapeTypeState.Input(stateContext, "line");

            stateContext.GetState().Should().Be(new InputPointState());
            stateContext.GetDrawer().GetType().Should().Be(typeof(LineDrawer));
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void should_throw_exception_when_input_invalid_shape_type()
        {
            var stateContext = new DrawPad();
            stateContext.GetState().Should().Be(new InputShapeTypeState());

            var inputShapeTypeState = new InputShapeTypeState();
            inputShapeTypeState.Input(stateContext, "");
        }
    }
}
