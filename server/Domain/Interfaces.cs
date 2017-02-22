﻿namespace CashMushroom.Domain
{
    public interface IDomainObject { }


    public interface IValueObject : IDomainObject { }

    public interface IEntity : IDomainObject { }


    public interface IDomainEvent : IValueObject { }

    public interface IException : IDomainEvent { }

    public interface ICommand : IValueObject { }

    public interface IAggregateRoot : IEntity { }
}