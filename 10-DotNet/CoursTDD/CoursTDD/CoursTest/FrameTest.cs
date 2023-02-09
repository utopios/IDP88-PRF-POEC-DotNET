using CoursTDD;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTest
{
    [TestClass]
    public class FrameTest
    {
        private Frame frame;
        private IGenerateur generateur = Mock.Of<IGenerateur>();
        [TestMethod]
        public void Roll_SimpleFrame_FirstRoll_CheckScore()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(10)).Returns(4);
            frame = new Frame(generateur, false);
            frame.MakeRoll();
            Assert.AreEqual(4, frame.Score);
        }

        [TestMethod]
        public void Roll_SimpleFrame_SecondRoll_CheckScore()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(6)).Returns(4);
            frame = new Frame(generateur, false);
            frame.Rolls = new List<Roll> { new Roll(4) };
            frame.MakeRoll();
            Assert.AreEqual(8, frame.Score);
        }
        [TestMethod]
        public void Roll_SimpleFrame_SecondRoll_FirstRollStrick_ReturnFalse()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(4)).Returns(4);
            frame = new Frame(generateur, false);
            frame.Rolls = new List<Roll> { new Roll(10) };
            bool res = frame.MakeRoll();
            Assert.IsFalse(res);
        }
        [TestMethod]
        public void Roll_SimpleFrame_MoreRolls_ReturnFalse()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(4)).Returns(4);
            frame = new Frame(generateur, false);
            frame.Rolls = new List<Roll> { new Roll(4), new Roll(5) };
            bool res = frame.MakeRoll();
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Roll_LastFrame_MoreRolls_ReturnFalse()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(4)).Returns(4);
            frame = new Frame(generateur, true);
            frame.Rolls = new List<Roll> { new Roll(4), new Roll(5) };
            bool res = frame.MakeRoll();
            Assert.IsFalse(res);
        }
        [TestMethod]
        public void Roll_LastFrame_SecondRoll_FirstRollStrick_ReturnTrue()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(4)).Returns(4);
            frame = new Frame(generateur, true);
            frame.Rolls = new List<Roll> { new Roll(10) };
            bool res = frame.MakeRoll();
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Roll_LastFrame_SecondRoll_FirstRollStrick_CheckScore()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(10)).Returns(4);
            frame = new Frame(generateur, true);
            frame.Rolls = new List<Roll> { new Roll(10) };
            bool res = frame.MakeRoll();
            Assert.AreEqual(14, frame.Score);
        }
        [TestMethod]
        public void Roll_LastFrame_ThirdRoll_FirstRollStrick_ReturnTrue()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(4)).Returns(4);
            frame = new Frame(generateur, true);
            frame.Rolls = new List<Roll> { new Roll(10), new Roll(6) };
            bool res = frame.MakeRoll();
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Roll_LastFrame_ThirdRoll_FirstRollStrick_CheckScore()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(4)).Returns(4);
            frame = new Frame(generateur, true);
            frame.Rolls = new List<Roll> { new Roll(10), new Roll(6) };
            bool res = frame.MakeRoll();
            Assert.AreEqual(20, frame.Score);
        }
        [TestMethod]
        public void Roll_LastFrame_ThirdRoll_Spare_ReturnTrue()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(10)).Returns(4);
            frame = new Frame(generateur, true);
            frame.Rolls = new List<Roll> { new Roll(4), new Roll(6) };
            bool res = frame.MakeRoll();
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Roll_LastFrame_ThirdRoll_Spare_CheckScore()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(10)).Returns(4);
            frame = new Frame(generateur, true);
            frame.Rolls = new List<Roll> { new Roll(4), new Roll(6) };
            bool res = frame.MakeRoll();
            Assert.AreEqual(14, frame.Score);
        }
        [TestMethod]
        public void Roll_LastFrame_FourthRoll_ReturnFalse()
        {
            Mock.Get(generateur).Setup(x => x.RandomPin(10)).Returns(4);
            frame = new Frame(generateur, true);
            frame.Rolls = new List<Roll> { new Roll(4), new Roll(6), new Roll(4) };
            bool res = frame.MakeRoll();
            Assert.IsFalse(res);
        }
    }
}
