using System;
using Xunit;
using cv_2_html.Controllers;

namespace CvToHtml.tests {
    public class UnitTest1 {
        [Fact]
        public void Test1() {
            WordToHTMLController wth = new WordToHTMLController();
            Assert.True(wth.Convert());
        }
    }
}
