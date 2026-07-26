import React, { Component } from "react";
import "./App.css";

class App extends Component {
  constructor() {
    super();

    this.state = {
      count: 0,
      amount: "",
      currency: "",
    };
  }

  increment = () => {
    this.setState({ count: this.state.count + 1 });
    this.sayHello();
  };

  decrement = () => {
    this.setState({ count: this.state.count - 1 });
  };

  sayHello = () => {
    alert("Hello! Member");
  };

  sayWelcome = (msg) => {
    alert(msg);
  };

  onPress = () => {
    alert("I was clicked");
  };

  handleChange = (e) => {
    this.setState({
      [e.target.name]: e.target.value,
    });
  };

  handleSubmit = (e) => {
    e.preventDefault();

    const euro = (parseFloat(this.state.amount) / 90).toFixed(2);

    this.setState({
      currency: euro,
    });

    alert(`Converting to Euro Amount is ${euro}`);
  };

  render() {
    return (
      <div className="container">
        <h2>{this.state.count}</h2>

        <button onClick={this.increment}>Increment</button>
        <br /><br />

        <button onClick={this.decrement}>Decrement</button>
        <br /><br />

        <button onClick={() => this.sayWelcome("Welcome")}>
          Say Welcome
        </button>
        <br /><br />

        <button onClick={this.onPress}>Click on me</button>

        <h1 className="title">Currency Convertor!!!</h1>

        <form onSubmit={this.handleSubmit}>
          <label>Amount</label>
          <input
            type="number"
            name="amount"
            value={this.state.amount}
            onChange={this.handleChange}
          />

          <br /><br />

          <label>Currency</label>
          <input
            type="text"
            value={this.state.currency}
            readOnly
          />

          <br /><br />

          <button type="submit">Submit</button>
        </form>
      </div>
    );
  }
}

export default App;