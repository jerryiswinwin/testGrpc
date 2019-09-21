using System.Threading.Tasks;
using Demo.Message;
using Google.Protobuf.Collections;
using Grpc.Core;

namespace Demo.Server
{
    public class DemoServiceImpl:DemoService.DemoServiceBase
    {
        public override async Task<GreetingResponse> Say(GreetingMsg request, ServerCallContext context)
        {
            var greetingMsg =request.Value;
            return new GreetingResponse
            {
                MsgValue = "this is "+greetingMsg,
                ReturnValue = "this is ReturnValue"
            };
        }

        public override async Task<TestResponse> TestWithEmpty(EmptyMsg request, ServerCallContext context)
        {
            var returnMsg = new TestResponse
            {
                Values = { 1,2,3,4}
            };
            
            return returnMsg;
        }
    }
}