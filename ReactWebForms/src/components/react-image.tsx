 
//define properties for this component
interface iReactImageProps {
    imageName: string
}

class ReactImage extends React.Component<iReactImageProps> {
    render() {
        //let imageElement = <img alt="" src="" />;
        return <h1>react-image.tsx: Image Name , {this.props.imageName}</h1>;
    }
}

 