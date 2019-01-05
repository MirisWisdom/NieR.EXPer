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

using NUnit.Framework;

namespace YuMi.NieRexper.Tests
{
    [TestFixture]
    public class ExperienceFactoryTests
    {
        [Test]
        public void ProvideLevel1_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(0, ExperienceFactory.FromLevel((Level) 1).Points);
        }

        [Test]
        public void ProvideLevel10_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(3184, ExperienceFactory.FromLevel((Level) 10).Points);
        }

        [Test]
        public void ProvideLevel25_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(34493, ExperienceFactory.FromLevel((Level) 25).Points);
        }

        [Test]
        public void ProvideLevel50_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(209127, ExperienceFactory.FromLevel((Level) 50).Points);
        }

        [Test]
        public void ProvideLevel75_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(600135, ExperienceFactory.FromLevel((Level) 75).Points);
        }

        [Test]
        public void ProvideLevel99_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(1235211, ExperienceFactory.FromLevel((Level) 99).Points);
        }
    }
}