class ComplexGenericCref
{
    /// <inheritdoc cref="Merge{TKey}(Dictionary{TKey,IValidator},Dictionary{TKey,IValidator})" />
    Dictionary<TKey, ValidatorBase<T>> Merge<TKey, T>(
        Dictionary<TKey, ValidatorBase<T>> first, 
        Dictionary<TKey, ValidatorBase<T>> second)
        where TKey : notnull
    {
        #region ...
        var result = new Dictionary<TKey, ValidatorBase<T>>(first);
        foreach (var entry in second)
        {
            result[entry.Key] = entry.Value;
        }
        return result;
        #endregion
    }

    /// <summary>
    /// Merges two collections into one.
    /// When collections are empty, an empty collection is returned.
    /// </summary>
    Dictionary<TKey, IValidator> Merge<TKey>(
        Dictionary<TKey, IValidator> first, 
        Dictionary<TKey, IValidator> second)
        where TKey : notnull
    {
        #region ...
        var result = new Dictionary<TKey, IValidator>(first);
        foreach (var entry in second)
        {
            result[entry.Key] = entry.Value;
        }
        return result;
        #endregion
    }
}

class NoBewilderingLinks
{
    /// <inheritdoc cref="_merge" />
    Dictionary<TKey, ValidatorBase<T>> Merge<TKey, T>(
        Dictionary<TKey, ValidatorBase<T>> first, 
        Dictionary<TKey, ValidatorBase<T>> second)
        where TKey : notnull
    {
        #region ...
        var result = new Dictionary<TKey, ValidatorBase<T>>(first);
        foreach (var entry in second)
        {
            result[entry.Key] = entry.Value;
        }
        return result;
        #endregion
    }

    /// <inheritdoc cref="_merge" />
    Dictionary<TKey, IValidator> Merge<TKey>(
        Dictionary<TKey, IValidator> first, 
        Dictionary<TKey, IValidator> second)
        where TKey : notnull
    {
        #region ...
        var result = new Dictionary<TKey, IValidator>(first);
        foreach (var entry in second)
        {
            result[entry.Key] = entry.Value;
        }
        return result;
        #endregion
    }
}