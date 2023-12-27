export interface semester{
    id: number,
    semester : string
}

// note that the ? operator tells us the 
// property is nullable, meaning its optional

// To define a new one:
// let test = {id: 3, semester: 'Spring'};

// you mark a property as readonly if you only want it to be
// assigned at object creation