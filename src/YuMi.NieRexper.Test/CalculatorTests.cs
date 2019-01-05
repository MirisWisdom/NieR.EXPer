/**
 * Copyright (C) 2018-2019 Emilian Roman
 * 
 * This file is part of NieR.EXPer.
 * 
 * NieR.EXPer is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * NieR.EXPer is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with NieR.EXPer.  If not, see <http://www.gnu.org/licenses/>.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YuMi.NieRexper.Test
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void ProvideLevel1_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new Calculator().Calculate((Level) 1) == 0);
        }

        [TestMethod]
        public void ProvideLevel10_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new Calculator().Calculate((Level) 10) == 3184);
        }

        [TestMethod]
        public void ProvideLevel25_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new Calculator().Calculate((Level) 25) == 34493);
        }

        [TestMethod]
        public void ProvideLevel50_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new Calculator().Calculate((Level) 50) == 209127);
        }

        [TestMethod]
        public void ProvideLevel75_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new Calculator().Calculate((Level) 75) == 600135);
        }

        [TestMethod]
        public void ProvideLevel99_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new Calculator().Calculate((Level) 99) == 1235211);
        }
    }
}