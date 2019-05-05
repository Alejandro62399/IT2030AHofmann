using System.Linq;
using Moq;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.Controllers;
using MovieStore.Models;
using System.Data.Entity;

namespace MovieStore.Tests.Controllers
{
    [TestClass]
    public class MovieStoreControllerTest
    { 
        [TestMethod]
        public void MovieStore_Index_TestView()
        {
            MoviesController controller = new MoviesController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void MovieStore_ListOfMovies()
        {
            MoviesController controller = new MoviesController();

            List<Movie> result = controller.ListOfMovies;

            Assert.IsNotNull(result);
            Assert.AreEqual(expected: "Iron Man 1", actual: result[0].Title);
            Assert.AreEqual(expected: "Iron Man 2", actual: result[1].Title);
            Assert.AreEqual(expected: "Iron Man 3", actual: result[2].Title);
        }
        [TestMethod]
        public void MovieStore_IndexRedirect_Success()
        {

            MoviesController controller = new MoviesController();

            RedirectToRouteResult result = controller.IndexRedirect(id: 1) as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(expected: "Create", actual: result.RouteValues["action"]);
            Assert.AreEqual(expected: "HomeController", actual: result.RouteValues["controller"]);

        }
        [TestMethod]
        public void MovieStore_IndexRedirect_BadRequest()
        {

            MoviesController controller = new MoviesController();

            HttpStatusCodeResult result = controller.IndexRedirect(id: 0) as HttpStatusCodeResult;

            Assert.AreEqual(expected: HttpStatusCode.BadRequest, actual: result.StatusCode);
        }
        [TestMethod]
        public void MovieStore_ListFromDb()
        {
            var list = new List<Movie>
        {
            new Movie() {MovieId = 1, Title = "Superman 1"},
            new Movie() {MovieId = 2, Title = "Superman 2"}
        }.AsQueryable();

            Mock<MovieStoreDBContext> mockContext = new Mock<MovieStoreDBContext>();
            Mock<DbSet<Movie>> mockSet = new Mock<DbSet<Movie>>();

            mockSet.As<IQueryable<Movie>>().Setup(expression: m => m.GetEnumerator()).Returns(list.GetEnumerator());
            mockSet.As<IQueryable<Movie>>().Setup(expression: m => m.Provider).Returns(list.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(expression: m => m.ElementType).Returns(list.ElementType);



            mockContext.Setup(expression: db => db.Movies).Returns(mockSet.Object);

            MoviesController controller = new MoviesController(mockContext.Object);

            ViewResult result = controller.ListFromDb() as ViewResult;
            List<Movie> resultMovies = result.Model as List<Movie>;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void MovieStore_Details_IdIsNull()
        {
            var list = new List<Movie>
        {
            new Movie() {MovieId = 1, Title = "Superman 1"},
            new Movie() {MovieId = 2, Title = "Superman 2"}
        }.AsQueryable();

            Mock<MovieStoreDBContext> mockContext = new Mock<MovieStoreDBContext>();
            Mock<DbSet<Movie>> mockSet = new Mock<DbSet<Movie>>();

            mockSet.As<IQueryable<Movie>>().Setup(expression: m => m.GetEnumerator()).Returns(list.GetEnumerator());
            mockSet.As<IQueryable<Movie>>().Setup(expression: m => m.Provider).Returns(list.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(expression: m => m.ElementType).Returns(list.ElementType);
            mockSet.Setup(expression: m => m.Find(It.IsAny<object>())).Returns(list.First());



            mockContext.Setup(expression: db => db.Movies).Returns(mockSet.Object);

            MoviesController controller = new MoviesController(mockContext.Object);

            HttpStatusCodeResult result = controller.Details(id: null) as HttpStatusCodeResult;

            Assert.AreEqual(expected: HttpStatusCode.BadRequest, actual: (HttpStatusCode)result.StatusCode);
        }
        [TestMethod]
        public void MovieStore_Details_MovieIsNull()
        {
            var list = new List<Movie>
        {
            new Movie() {MovieId = 1, Title = "Superman 1"},
            new Movie() {MovieId = 2, Title = "Superman 2"}
        }.AsQueryable();

            Mock<MovieStoreDBContext> mockContext = new Mock<MovieStoreDBContext>();
            Mock<DbSet<Movie>> mockSet = new Mock<DbSet<Movie>>();

            mockSet.As<IQueryable<Movie>>().Setup(expression: m => m.GetEnumerator()).Returns(list.GetEnumerator());
            mockSet.As<IQueryable<Movie>>().Setup(expression: m => m.Provider).Returns(list.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(expression: m => m.ElementType).Returns(list.ElementType);

            Movie movie = null;

            mockSet.Setup(expression: m => m.Find(It.IsAny<object>())).Returns(movie);



            mockContext.Setup(expression: db => db.Movies).Returns(mockSet.Object);

            MoviesController controller = new MoviesController(mockContext.Object);

            HttpStatusCodeResult result = controller.Details(id: 0) as HttpStatusCodeResult;

            Assert.AreEqual(expected: HttpStatusCode.NotFound, actual: (HttpStatusCode)result.StatusCode);
        }
    }
}

   

  
