public class SqlQuery
{
    public string SelectPart { get; set; }
    public string WherePart { get; set; }
    public string OrderByPart { get; set; }

    public override string ToString()
    {
        return $"{SelectPart} {WherePart} {OrderByPart}".Trim();
    }
}

public class SqlQueryBuilder
{
    private SqlQuery query = new SqlQuery();

    public SqlQueryBuilder Select(string fields)
    {
        query.SelectPart = $"SELECT {fields}";
        return this;
    }

    public SqlQueryBuilder Where(string condition)
    {
        query.WherePart = $"WHERE {condition}";
        return this;
    }

    public SqlQueryBuilder OrderBy(string field)
    {
        query.OrderByPart = $"ORDER BY {field}";
        return this;
    }

    public SqlQuery Build()
    {
        return query;
    }
}
