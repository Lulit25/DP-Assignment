//typescript program

interface SampleConstructor {
    new (): Sample;
}

interface Sample{
    Action(): any;
}

class Test implements Sample {
    public Action() {
        return "nothing important";
    }
}

let array : SampleConstructor[] = [Test];