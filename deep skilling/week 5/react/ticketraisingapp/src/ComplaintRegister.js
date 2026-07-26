import React, { Component } from "react";
import "./App.css";

class ComplaintRegister extends Component {
  constructor() {
    super();

    this.state = {
      ename: "",
      complaint: "",
      NumberHolder: Math.floor(Math.random() * 100) + 1,
    };
  }

  handleChange = (event) => {
    this.setState({
      [event.target.name]: event.target.value,
    });
  };

  handleSubmit = (event) => {
  event.preventDefault();

  const refNo = Math.floor(Math.random() * 100) + 1;

  alert(
    "Thanks " +
      this.state.ename +
      "\n\nYour Complaint was Submitted.\n\nTransaction ID: " +
      refNo
  );
};

  render() {
    return (
      <div className="container">
        <h1>Register your complaints here!!!</h1>

        <form onSubmit={this.handleSubmit}>
          <table>
            <tbody>
              <tr>
                <td>Name:</td>

                <td>
                  <input
                    type="text"
                    name="ename"
                    value={this.state.ename}
                    onChange={this.handleChange}
                  />
                </td>
              </tr>

              <tr>
                <td>Complaint:</td>

                <td>
                  <textarea
                    name="complaint"
                    value={this.state.complaint}
                    onChange={this.handleChange}
                  />
                </td>
              </tr>

              <tr>
                <td></td>

                <td>
                  <button type="submit">Submit</button>
                </td>
              </tr>
            </tbody>
          </table>
        </form>
      </div>
    );
  }
}

export default ComplaintRegister;