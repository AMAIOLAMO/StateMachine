# StateMachine
---
> A very basic, super easy to use, flexible State machine!

### Usage

**to use this is pretty simple:**

first, you'll create a state, here I'll use an enum:
```cs
public enum FooState
{
  Foo, Bar
}
```

next, you'll need to create an instance of `StateMachine<T>` and pass your state into it:
```cs
StateMachine<FooState> _myStateMachine;
```

and voila! You have a very basic single state, state machine setup!

now to set a state, you can do:
`_myStateMachine.SetState(FooState.Foo);`

and to listen to a state change:
```
void Register()
{
  _myStateMachine.StateChanged += StateChangedEventHandler;
}

void StateChangedEventHandler(FooState previousState, FooState newState)
{
  // do stuff
}
```

or want to see what state are avalible:
```cs
var previousState = _myStateMachine.PreviousState;
var currentState = _myStateMachine.State;
```

### Flexibility

if you need to implement your own state machine, do not worry! I have also added a interface `IStateMachine<T>` for that case.
for more detail on how to implement, check the [`StateMachine<T>`](https://github.com/AMAIOLAMO/StateMachine/blob/master/Src/Domain/StateMachine.cs)


Made by CXRedix, Licensed Under MIT
