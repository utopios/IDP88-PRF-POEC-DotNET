function Header() {
    return (
        <div className="header">
            <img src="./img/M2ILOGO2.png" alt="Logo- M2I" />
            <h2>M2IFormation</h2>

        </div>
    )
}
function Description() {
    const text = "Votre Formation Sur Mesure";
    return (
        <span><i>{text.toLocaleLowerCase()}</i></span>
    )
}

function LeftComponent() {
    return (
        <div className="left">
            <p>Left</p>
        </div>
    )
}
function RightComponent() {
    return (
        <div className="right">
            <p>Right</p>
        </div>
    )
}
function CenterComponent() {
    return (
        <div className="center">
            <p>Center</p>
        </div>
    )
}
function Footer() {
    return (
        <div className="footer">
            <p>Ma premiere page perso générée par react - Copyright@2022 - <a href="mailto:anthony@utopios.net">Me contacter</a></p>
        </div>
    )
}

function App() {
    return (
        <div>
            <div className="banner">
                <Header />
                <div className="description">
                    <Description />
                </div>
            </div>
            <div className="row">
                <div className="col-2 left">
                    <LeftComponent />
                </div>
                <div className="col-8 center">
                    <CenterComponent />
                </div>
                <div className="col-2 right">
                    <RightComponent />

                </div>
            </div>
            <div className="footer">
                <Footer />
            </div>
        </div>
    )
}

ReactDOM.render(
    <React.Fragment>
        <App />
    </React.Fragment>,
    document.getElementById('app')
);