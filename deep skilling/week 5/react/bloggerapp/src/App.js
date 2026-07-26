import BookDetails from "./BookDetails";
import BlogDetails from "./BlogDetails";
import CourseDetails from "./CourseDetails";

function App() {

  const showBooks = true;
  const showBlogs = true;
  const showCourses = true;

  return (
    <div
      style={{
        display: "flex",
        justifyContent: "space-around",
        padding: "20px"
      }}
    >
      {showCourses && (
        <div
          style={{
            borderRight: "3px solid green",
            paddingRight: "20px"
          }}
        >
          <CourseDetails />
        </div>
      )}

      {showBooks && (
        <div
          style={{
            borderRight: "3px solid green",
            paddingRight: "20px"
          }}
        >
          <BookDetails />
        </div>
      )}

      {showBlogs && (
        <div>
          <BlogDetails />
        </div>
      )}
    </div>
  );
}

export default App;