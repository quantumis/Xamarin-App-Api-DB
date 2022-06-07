using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Web_API_COMP.Entitnes;
using Web_API_COMP.Models;

namespace Web_API_COMP.Controllers
{
    public class ComponentsController : ApiController
    {
        private COMP_FIRMEntities db = new COMP_FIRMEntities();

        // GET: api/Components
        [ResponseType(typeof(List<ResponseComponents>))]
        public IHttpActionResult GetComponents()
        {
            return Ok(db.Components.ToList().ConvertAll(p => new ResponseComponents(p)));
        }

        // GET: api/Components/5
        [ResponseType(typeof(Components))]
        public IHttpActionResult GetComponents(int id)
        {
            Components components = db.Components.Find(id);
            if (components == null)
            {
                return NotFound();
            }

            return Ok(components);
        }

        // PUT: api/Components/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutComponents(int id, Components components)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != components.id)
            {
                return BadRequest();
            }

            db.Entry(components).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComponentsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Components
        [ResponseType(typeof(Components))]
        public IHttpActionResult PostComponents(Components components)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Components.Add(components);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = components.id }, components);
        }

        // DELETE: api/Components/5
        [ResponseType(typeof(Components))]
        public IHttpActionResult DeleteComponents(int id)
        {
            Components components = db.Components.Find(id);
            if (components == null)
            {
                return NotFound();
            }

            db.Components.Remove(components);
            db.SaveChanges();

            return Ok(components);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ComponentsExists(int id)
        {
            return db.Components.Count(e => e.id == id) > 0;
        }
    }
}