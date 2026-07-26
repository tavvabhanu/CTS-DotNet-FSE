import React, { Component } from "react";

class Getuser extends Component {
  constructor() {
    super();

    this.state = {
      title: "",
      firstname: "",
      image: "",
    };
  }

  async componentDidMount() {
    const response = await fetch("https://api.randomuser.me/");
    const data = await response.json();

    this.setState({
      title: data.results[0].name.title,
      firstname: data.results[0].name.first,
      image: data.results[0].picture.large,
    });
  }

  render() {
    return (
      <div className="container">
        <h1>
          {this.state.title} {this.state.firstname}
        </h1>

        <img
          src={this.state.image}
          alt="User"
          width="120"
          height="120"
        />
      </div>
    );
  }
}

export default Getuser;