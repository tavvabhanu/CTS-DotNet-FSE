import React from "react";

import office1 from "./images/office1.jpg";
import office2 from "./images/office2.jpg";
import office3 from "./images/office3.jpg";
import office4 from "./images/office4.jpg";

function App() {
  const officeList = [
    {
      Name: "DBS",
      Rent: 50000,
      Address: "Chennai",
      Image: office1,
    },
    {
      Name: "Infosys Office",
      Rent: 75000,
      Address: "Hyderabad",
      Image: office2,
    },
    {
      Name: "Tech Park",
      Rent: 45000,
      Address: "Bangalore",
      Image: office3,
    },
    {
      Name: "Cyber Towers",
      Rent: 90000,
      Address: "Pune",
      Image: office4,
    },
  ];

  return (
    <div style={{ marginLeft: "40px", marginTop: "20px" }}>
      <h1>Office Space, at Affordable Range</h1>

      {officeList.map((officeItem, index) => (
        <div
          key={index}
          style={{
            marginBottom: "40px",
            border: "1px solid gray",
            width: "300px",
            padding: "15px",
            borderRadius: "10px",
          }}
        >
          <img
            src={officeItem.Image}
            alt={officeItem.Name}
            width="250"
            height="180"
          />

          <h2>Name: {officeItem.Name}</h2>

          <h3
            style={{
              color: officeItem.Rent < 60000 ? "red" : "green",
            }}
          >
            Rent: Rs. {officeItem.Rent}
          </h3>

          <h3>Address: {officeItem.Address}</h3>
        </div>
      ))}
    </div>
  );
}

export default App;