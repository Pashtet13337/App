using System.Threading;
using System.Threading.Tasks;
using ITHUBApp.DAL.DataObjects;

namespace ITHUBApp.DAL.DataServices {
	public interface IMainDataService {
		Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx);
	}
}



