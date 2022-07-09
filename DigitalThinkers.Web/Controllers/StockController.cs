using DigitalThinkers.CashierService;
using DigitalThinkers.CashierService.Models;
using DigitalThinkers.Common.Entities;
using DigitalThinkers.Common.Entities.Enumerations;
using DigitalThinkers.Models;
using DigitalThinkers.Models.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DigitalThinkers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private ILogger _logger;
        private ICashierService _cashierService;

        public StockController(ILogger<StockController> logger, ICashierService cashierService)
        {
            this._logger = logger;
            this._cashierService = cashierService;
        }

        [HttpGet]
        public virtual ActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public virtual ActionResult Index([FromBody] StockRequestDto request)
        {
            var stockUpResponse = new StockUpResponse();

            var denominations = this.ConvertMoneyLoadedToDenomination(request.MoneyLoaded, request.Currency);

            var stockUpRequest = new DenominationsLoadRequest()
            {
                Denominations = denominations
            };
            
            var stockUpResult = this._cashierService.StockUpDenominations(stockUpRequest);
            if (!stockUpResult.IsSuccessful)
            {
                stockUpResponse.Errors.Add(stockUpResult.ToString());
                return BadRequest(stockUpResponse);
            }


            return Ok(stockUpResponse);
        }

        private Denominations ConvertMoneyLoadedToDenomination(MoneyLoaded moneyLoaded, string currency)
        {

            var denomination = new Denominations();

            if (moneyLoaded.One > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.One,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.One
                });
            }
            if (moneyLoaded.Two > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.Two,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.Two
                });
            }
            if (moneyLoaded.Five > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.Five,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.Five
                });
            }
            if (moneyLoaded.Ten > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.Ten,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.Ten
                });
            }
            if (moneyLoaded.Twenty > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.Twenty,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.Twenty
                });
            }
            if (moneyLoaded.Fifty > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.Fifty,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.Fifty
                });
            }
            if (moneyLoaded.Hundred > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.Hundred,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.Hundred
                });
            }
            if (moneyLoaded.FiveHundred  > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.FiveHundred,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.FiveHundred
                });
            }
            if (moneyLoaded.Thousand > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.Thousand,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.Thousand
                });
            }
            if (moneyLoaded.TwoThousand > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.TwoThousand,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.TwoThousand
                });
            }
            if (moneyLoaded.FiveThousand > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.FiveThousand,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.FiveThousand
                });
            }
            if (moneyLoaded.TenThousand > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.TenThousand,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.TenThousand
                });
            }
            if (moneyLoaded.TwentyThousand > 0)
            {
                denomination.MoneyInTransfer.Add(new Money()
                {
                    Count = moneyLoaded.TwentyThousand,
                    CurrencyType = TryToGetCurrencyType(currency),
                    ValueType = ValueType.TwentyThousand
                });
            }

            return denomination;
        }

        private CurrencyType TryToGetCurrencyType(string currency)
        {
            CurrencyType currencyType = CurrencyType.Unknown;

            switch (currency)
            {
                case "EUR":
                    currencyType = CurrencyType.EUR;
                    break;
                case "HUF":
                    currencyType = CurrencyType.HUF;
                    break;
                default:
                    currencyType = CurrencyType.Unknown;
                    break;
            }

            return currencyType;
        }
    }
}
