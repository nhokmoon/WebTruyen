using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebTruyen.Infrastructure;

namespace WebTruyen.Models
{
    public class SessionTuTruyen:TuTruyen
    {
        public static TuTruyen GetTuTruyen(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionTuTruyen tutruyen = session?.Getjson<SessionTuTruyen>("TuTruyen") ?? new SessionTuTruyen();
            tutruyen.Session = session;
            return tutruyen;
        }

        public ISession Session { get; set; }

        public override void AddTruyen(Truyen truyen, int solantruycap)
        {
            base.AddTruyen(truyen, solantruycap);
            Session.SetJson("TuTruyen", this);
        }

        public override void RemoveTruyen(Truyen truyen)
        {
            base.RemoveTruyen(truyen);
            Session.SetJson("TuTruyen", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.SetJson("TuTruyen", this);
        }
    }
}
