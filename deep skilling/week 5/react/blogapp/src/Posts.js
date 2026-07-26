import React from "react";
import Post from "./Post";

class Posts extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      posts: []
    };
  }

  loadPosts() {
  const posts = [
    new Post(
      1,
      "Welcome to BlogApp",
      "BlogApp is a simple React application that displays blog posts using class components and React lifecycle methods."
    ),
    new Post(
      2,
      "Learning React",
      "React is a JavaScript library used for building interactive user interfaces. It uses reusable components and the Virtual DOM for better performance."
    ),
    new Post(
      3,
      "Component Lifecycle",
      "The componentDidMount() lifecycle method is called after a component is rendered. It is commonly used to fetch data from an API."
    ),
    new Post(
      4,
      "Why Choose React?",
      "React is easy to learn, supports reusable components, and helps developers build fast and modern web applications."
    ),
    new Post(
      5,
      "Future of Web Development",
      "Modern web development relies on frameworks like React to create responsive, scalable, and user-friendly applications."
    )
  ];

  this.setState({
    posts: posts
  });
}

  componentDidMount() {
    this.loadPosts();
  }

  componentDidCatch(error, info) {
    alert("Error: " + error);
    console.log(info);
  }

  render() {
    return (
      <div>
        <h1>Blog Posts</h1>

        {this.state.posts.map((post) => (
          <div key={post.id}>
            <h3>{post.title}</h3>
            <p>{post.body}</p>
            <hr />
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;