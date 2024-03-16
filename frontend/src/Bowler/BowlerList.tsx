import { Bowler } from '../types/Bowler';
import { useState } from 'react';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost');
      const f = await rsp.json();
      setBowlerData(f);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4>This Shows bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>First Name</th>
            <th>Middle Name</th>
            <th>Last Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((f) => (
            <tr key={f.BowlerId}>
              <td>{f.BowlerFirstName}</td>
              <td>{f.BowlerMiddleInit}</td>
              <td>{f.BowlerLastName}</td>
              <td>{f.TeamId}</td>
              <td>{f.BowlerAddress}</td>
              <td>{f.BowlerCity}</td>
              <td>{f.BowlerState}</td>
              <td>{f.BowlerZip}</td>
              <td>{f.BowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
function useEffect(arg0: () => void) {
  throw new Error('Function not implemented.');
}

function fetchBowlerData() {
  throw new Error('Function not implemented.');
}
