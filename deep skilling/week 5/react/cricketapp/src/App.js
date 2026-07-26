import ListofPlayers from "./ListofPlayers";
import {
  IndianTeam,
  IndianPlayers,
  OddPlayers,
  EvenPlayers
} from "./IndianPlayers";
import ListofIndianPlayers from "./ListofIndianPlayers";

function App() {

  let flag = true; // change to false for second output

  if (flag === false) {
    return (
      <div>
        <ListofPlayers />
      </div>
    );
  } else {
    return (
      <div>
        <h1>Indian Team</h1>

        <h2>Odd Players</h2>
        {OddPlayers(IndianTeam)}

        <hr />

        <h2>Even Players</h2>
        {EvenPlayers(IndianTeam)}

        <hr />

        <h2>List of Indian Players Merged</h2>
        <ListofIndianPlayers
          IndianPlayers={IndianPlayers}
        />
      </div>
    );
  }
}

export default App;