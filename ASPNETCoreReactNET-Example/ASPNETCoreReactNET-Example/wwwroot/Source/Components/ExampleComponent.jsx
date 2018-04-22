// This is our component.
class ExampleComponent extends React.Component {
    render() {
        return (
            <div className="testDiv">
                <h1>{this.props.user.name}</h1>
                <h3>{this.props.user.age}</h3>   
            </div>
        );
    }
}