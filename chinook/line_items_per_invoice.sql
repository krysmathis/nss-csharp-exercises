--Looking at the InvoiceLine table, provide a query that COUNTs the number of line items for each Invoice. HINT: GROUP BY
SELECT InvoiceId, Count(*) as LineCount FROM InvoiceLine
Group by InvoiceId;