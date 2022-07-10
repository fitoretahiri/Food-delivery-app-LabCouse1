import AppNavbar from "./AppNavbar"

const Kontakto = () => {
  return (
    <div className="">
      <AppNavbar />
      <h3 className="mt-5">Na Kontakto</h3>
      <div className="mt-5 w-50 mx-auto">
        <form>
          <div class="mb-3">
            <div class="row g-3">
              <div class="col">
                <input
                  type="text"
                  class="form-control"
                  placeholder="EMRI"
                  aria-label="Emri"
                />
              </div>
              <div class="col">
                <input
                  type="text"
                  class="form-control"
                  placeholder="MBIEMRI"
                  aria-label="Mbiemri"
                />
              </div>
            </div>
            <div class="mb-3 mt-3">
              <label for="formGroupExampleInput" class="form-label">
                Subjekti
              </label>
              <input
                type="text"
                class="form-control"
                id="formGroupExampleInput"
                placeholder="Subjekti Mesazhit"
              />
            </div>
            <div class="mb-3">
              <label for="exampleFormControlTextarea1" class="form-label">
                Mesazhi Juaj
              </label>
              <textarea
                class="form-control"
                id="exampleFormControlTextarea1"
                rows="3"
              ></textarea>
            </div>
          </div>
          <button type="submit" class="btn btn-primary">
            Submit
          </button>
        </form>
      </div>
    </div>
  )
}

export default Kontakto
