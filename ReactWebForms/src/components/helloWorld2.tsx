
//tsx component
 

//define properties for this component
interface iprops {
    name: string,
    tel: string,
    user: string
}

class HelloWorld2 extends React.Component<iprops> {
    render() {
        return <h1>helloWorld2.tsx: Hello, {this.props.name}</h1>;
    }
}

