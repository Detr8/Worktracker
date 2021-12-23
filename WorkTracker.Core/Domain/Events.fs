module Events

type EventWrapper<'Event>={
    AggregateId:string;
    Body:'Event;
}

type DomainEvent={Name:string}