import logo from './BowlingBuddies.png';

function Header() {
  return (
    <header className="row navbar bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" />
      </div>

      <div className="col subtitle">
        <h1 className="text-white">Bowler for Life</h1>
      </div>
    </header>
  );
}

export default Header;
